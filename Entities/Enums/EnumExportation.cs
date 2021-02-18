using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Entities.Enums
{
    public class ExportEnum
    {
        public string MyEumJson
        {
            get
            {
                return JsonConvert.SerializeObject(Enum.GetValues(typeof(Units_Of_Measurement)), new Newtonsoft.Json.Converters.StringEnumConverter());
            }
        }
    }
}
