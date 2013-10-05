using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace DALRemote
{
    /// <summary>
    /// Controller class for ProspectusLinkRequestExt
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ProspectusLinkRequestExtController
    {
        // Preload our schema..
        ProspectusLinkRequestExt thisSchemaLoad = new ProspectusLinkRequestExt();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public ProspectusLinkRequestExtCollection FetchAll()
        {
            ProspectusLinkRequestExtCollection coll = new ProspectusLinkRequestExtCollection();
            Query qry = new Query(ProspectusLinkRequestExt.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ProspectusLinkRequestExtCollection FetchByID(object Id)
        {
            ProspectusLinkRequestExtCollection coll = new ProspectusLinkRequestExtCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ProspectusLinkRequestExtCollection FetchByQuery(Query qry)
        {
            ProspectusLinkRequestExtCollection coll = new ProspectusLinkRequestExtCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (ProspectusLinkRequestExt.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (ProspectusLinkRequestExt.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? ExternalID,string Facility,string City,string State,string Country,string Salesperson,int? SalespersonID,string ContactName,string ContactEmail,bool? Synched)
	    {
		    ProspectusLinkRequestExt item = new ProspectusLinkRequestExt();
		    
            item.ExternalID = ExternalID;
            
            item.Facility = Facility;
            
            item.City = City;
            
            item.State = State;
            
            item.Country = Country;
            
            item.Salesperson = Salesperson;
            
            item.SalespersonID = SalespersonID;
            
            item.ContactName = ContactName;
            
            item.ContactEmail = ContactEmail;
            
            item.Synched = Synched;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? ExternalID,string Facility,string City,string State,string Country,string Salesperson,int? SalespersonID,string ContactName,string ContactEmail,bool? Synched)
	    {
		    ProspectusLinkRequestExt item = new ProspectusLinkRequestExt();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.ExternalID = ExternalID;
				
			item.Facility = Facility;
				
			item.City = City;
				
			item.State = State;
				
			item.Country = Country;
				
			item.Salesperson = Salesperson;
				
			item.SalespersonID = SalespersonID;
				
			item.ContactName = ContactName;
				
			item.ContactEmail = ContactEmail;
				
			item.Synched = Synched;
				
	        item.Save(UserName);
	    }
    }
}