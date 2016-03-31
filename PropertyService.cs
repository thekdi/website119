using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PropertyService
/// </summary>
public class PropertyService :DataService
{
	public PropertyService()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int infoid { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
}