using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CenterDetails
/// </summary>
[Serializable]
public class CenterDetails
{
    string cCode;
    string cName;
	public CenterDetails(string code,string name)
	{
        cCode = code;
        cName = name;
	}
    public string CenterCode
    {
        get
        {
            return cCode;
        }
        set
        {
            cCode = value;
        }
    }
    public string CenterName
    {
        get
        {
            return cName;
        }
        set
        {
            cName = value;
        }
    }
}