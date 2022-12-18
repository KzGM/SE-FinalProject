using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopTestSE.Models;

namespace ShopTestSE.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ShopConn db = new ShopConn();
        // GET: ShoppingCart
        private String strCart = "Cart";
        //private object lsCart;

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderNow(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            if (Session[strCart] == null)
            {
                List<Cart> lsCart = new List<Cart>
                {
                    new Cart(db.Products.Find(id),1)
                };
                Session[strCart] = lsCart;
            }
            else
            {
                List<Cart> lsCart = (List<Cart>)Session[strCart];
                int check = isExistingCheck(id);
                if (check == -1)
                {
                    lsCart.Add(new Cart(db.Products.Find(id), 1));
                }
                else
                {
                    lsCart[check].Quantity++;
                    Session[strCart] = lsCart;
                }
                //lsCart.Add(new Cart(db.Products.Find(id), 1));
            }

            return View("Index");
        }

        private int isExistingCheck(string id)
        {
            List<Cart> lsCart = (List<Cart>)Session[strCart];
            for (int i = 0; i < lsCart.Count; i++)
            {
                if (lsCart[i].Product.ProductID == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int check = isExistingCheck(id);
            List<Cart> lsCart = (List<Cart>)Session[strCart];
            lsCart.RemoveAt(check);
            return View("Index");
        }

        public ActionResult UpdateCart(FormCollection frc)
        {
            string[] quantity = frc.GetValues("quantity");
            List<Cart> lstCart = (List<Cart>)Session[strCart];
            for (int i = 0; i < lstCart.Count; i++)
            {
                lstCart[i].Quantity = Convert.ToInt32(quantity[i]);
            }
            Session[strCart] = lstCart;
            return View("Index");
        }

        public ActionResult CheckOut()
        {

            return View("CheckOut");
        }

        public ActionResult ConfirmOder(FormCollection frc)
        {
            List<Cart> lstCart = (List<Cart>)Session[strCart];
            Agent agent = new Agent()
            {
                AgentName = frc["cusName"],
                AgentPhone = frc["cusPhone"],
                AgentAddress = frc["cusAddress"],
            };
            db.Agents.Add(agent);
            db.SaveChanges();
            PaymentType paymentType = new PaymentType();
            Order order = new Order()
            {
                AgentID = agent.AgentID,
                PaymentTypeID = paymentType.PaymentTypeID,
                OrderDate = DateTime.Now
            };
            db.Orders.Add(order);
            db.SaveChanges();
            foreach (Cart cart in lstCart)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderID = order.OrderID,
                    ProductID = cart.Product.ProductID,
                    Quantity = cart.Quantity,
                    Price = cart.Product.Price,
                    Status = "Processing"
                };
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
            }
            Session.Remove(strCart);
            return View("OrderSuccess");
        }
    }
}