using Broadsign_Multi_Toolkit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadsign_Multi_Toolkit.Resources
{
    internal class Constants
    {
        const string ENDPOINT = @"https://api.broadsign.com:10899/rest";
        const string DISPLAY_UNIT_GET_PATH = @"/display_unit/v12";
        const string DISPLAY_UNIT_POST_PATH = @"/display_unit/v12/add";
        const string DISPLAY_UNIT_PUT_PATH = @"/display_unit/v12"; 
        const string SKIN_GET_PATH = @"/skin/v7";
        const string SKIN_UNIT_POST_PATH = @"/skin/v7add";
        const string SKIN_UNIT_PUT_PATH = @"/skin/v7"; 
        const string HOST_UNIT_GET_PATH = @"/host/v17";
        const string HOST_UNIT_POST_PATH = @"/host/v17""add";
        const string HOST_UNIT_PUT_PATH = @"/host/v17"; 
        const string DAYPART_UNIT_GET_PATH = @"/day_part/v5";
        const string DAYPART_UNIT_POST_PATH = @"/day_part/v5/add";
        const string DAYPART_UNIT_PUT_PATH = @"/day_part/v5/";

    }
}
