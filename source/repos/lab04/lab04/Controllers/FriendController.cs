using lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab04.Controllers
{
    public class FriendController : Controller
    {
        public static FriendsDB _friends = new FriendsDB();

        public ActionResult AllFriends()
        {
            return View(_friends.Friends.ToList());
        }

        public ActionResult newFriend()
        {
            FriendModel newFriend = new FriendModel();
            return View(newFriend);
        }

        [HttpPost]
        public ActionResult createFriend(FriendModel model)
        {
            if (!ModelState.IsValid)
                return View("newFriend", model);
            _friends.Friends.Add(model);
            _friends.SaveChanges();
            return RedirectToAction("AllFriends",_friends.Friends.ToList());
        }

        public ActionResult EditFriend(int id)
        {
            FriendModel fm = _friends.Friends.Find(id);
            return View(fm);
        }

        [HttpPost]
        public ActionResult EditConfirm(FriendModel model,int id)
        {
            if (!ModelState.IsValid)
                return View("EditFriend",model);
            FriendModel fm = _friends.Friends.Find(id);
            TryUpdateModel(fm);
            _friends.SaveChanges();
            return RedirectToAction("AllFriends",_friends.Friends.ToList());
        }

        public ActionResult DeleteFriend(int id)
        {
            FriendModel fm = _friends.Friends.Find(id);
            _friends.Friends.Remove(fm);
            _friends.SaveChanges();
            return RedirectToAction("AllFriends",_friends.Friends.ToList());
        }
    }
}