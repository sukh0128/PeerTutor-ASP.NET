using DHTMLX.Scheduler;
using DHTMLX.Scheduler.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeerTutor.Models;
using DHTMLX.Common;

namespace PeerTutor.Controllers
{
    public class BasicSchedulerController : Controller
    {
        public ActionResult Index()
        {
            var sched = new DHXScheduler(this);
            sched.Skin = DHXScheduler.Skins.Terrace;
            sched.LoadData = true;
            sched.EnableDataprocessor = true;
            sched.InitialDate = new DateTime(2016, 5, 5);
            return View(sched);
        }

        public ContentResult Data()
        {
            return (new SchedulerAjaxData(
                new DBOModel().Events
                .Select(e => new { e.id, e.text, e.start_date, e.end_date })
                )
                );
        }

        public ContentResult Save(int? id, FormCollection actionValues)
        {
            var action = new DataAction(actionValues);
            var changedEvent = DHXEventsHelper.Bind<Event>(actionValues);
            var entities = new DBOModel();
            try
            {
                switch (action.Type)
                {
                    case DataActionTypes.Insert:
                        entities.Events.Add(changedEvent);
                        break;
                    case DataActionTypes.Delete:
                        changedEvent = entities.Events.FirstOrDefault(ev => ev.id == action.SourceId);
                        entities.Events.Remove(changedEvent);
                        break;
                    default:// "update"
                        var target = entities.Events.Single(e => e.id == changedEvent.id);
                        DHXEventsHelper.Update(target, changedEvent, new List<string> { "id" });
                        break;
                }
                entities.SaveChanges();
                action.TargetId = changedEvent.id;
            }
            catch (Exception a)
            {
                action.Type = DataActionTypes.Error;
            }

            return (new AjaxSaveResponse(action));
        }
    }
}