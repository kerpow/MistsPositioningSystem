using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace MistPositioningSystem
{
    class AhhhDragonsReporter
    {

        public static void IssueReport(AhhhDragonsReport report)
        {
            if (!(report.Map == 38 || report.Map == 94 || report.Map == 95 || report.Map == 96))
                return;

            var serializer = new JavaScriptSerializer();
            if (!string.IsNullOrWhiteSpace(report.Name))
            {
                using (var wb = new WebClient())
                {

                    var data = new NameValueCollection();

                    data["mtc"] = report.MistsTrackingCode;
                    data["name"] = report.Name;
                    data["map"] = report.Map.ToString();
                    data["posx"] = report.PosX.ToString();
                    data["posy"] = report.PosY.ToString();
                    data["posz"] = report.PosZ.ToString();
                    data["friendly"] = report.GroupAllegiance == AhhhDragonsReport.PlayerGroupAllegiance.Friend ? "1" : "0";
                    data["size"] = ((int)report.GroupSize).ToString();

                    var response = wb.UploadValues("http://localhost:1234/db/wvw.php", "POST", data);
                    System.Diagnostics.Debug.WriteLine(Encoding.ASCII.GetString(response));

                }


            }
        }
    }
}
