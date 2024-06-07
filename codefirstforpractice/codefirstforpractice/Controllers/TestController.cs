using codefirstforpractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirstforpractice.Controllers
{
    public class TestController : Controller
    {
        playerscontext pc = new playerscontext();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.pc.players.ToList());
        }
        public ActionResult ind()
        {
            ViewBag.countryid = new SelectList(this.pc.countries.ToList(), "countryid", "countryname");
            var v = from t1 in this.pc.players
                    join t2 in this.pc.teams
                    on t1.teamid equals t2.teamid
                    join t3 in this.pc.sportseries
                    on t1.sportseriesid equals t3.sportseriesid
                    join t4 in this.pc.countries
                    on t2.countryid equals t4.countryid
                    select new classofVM
                    {
                        teamid=t2.teamid,
                        teamname = t2.teamname,
                        scoreplayer = t1.scoreplayer

                    };

            return View(v);
        }

        public ActionResult searchbycountry(Int64 countryid = 0)
        {
            ViewBag.countryid = new SelectList(this.pc.countries.ToList(), "countryid", "countryname");
            if (countryid == 0)
            {

                return RedirectToAction("Index", this.pc.players.ToList());
            }
            else
            {
                var v = from t1 in this.pc.players
                        join t2 in this.pc.teams
                        on t1.teamid equals t2.teamid
                        join t3 in this.pc.sportseries
                        on t1.sportseriesid equals t3.sportseriesid
                        join t4 in this.pc.countries
                        on t2.countryid equals t4.countryid
                        where (t4.countryid == countryid)
                        select new classofVM
                        {
                            teamid=t2.teamid,
                            teamname = t2.teamname,
                            scoreplayer = t1.scoreplayer

                        };

                return View("ind", v.ToList());



            }

        }
    }
}