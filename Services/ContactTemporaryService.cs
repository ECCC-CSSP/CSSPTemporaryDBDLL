using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSSPTemporaryDBDLL.Services
{
    public partial class ContactTemporaryService
    {
        #region Variables
        #endregion Variables

        #region Properties
        CSSPTemporaryDBEntities db { get; set; }
        #endregion Properties

        #region Constructors
        public ContactTemporaryService()
        {
            db = new CSSPTemporaryDBEntities();
        }
        #endregion Constructors

        #region Functions public
        public string ContactAddOrModify(Contact contact)
        {
            Contact contactExist = (from c in db.Contacts
                                    where c.LoginEmail == contact.LoginEmail
                                    select c).FirstOrDefault();

            if (contactExist == null)
            {
                contactExist = new Contact();
                contactExist.ContactID = contact.ContactID;
                contactExist.DBCommand = contact.DBCommand;
                contactExist.Id = contact.Id;
                contactExist.ContactTVItemID = contact.ContactTVItemID;
                contactExist.LoginEmail = contact.LoginEmail;
                contactExist.FirstName = contact.FirstName;
                contactExist.LastName = contact.LastName;
                contactExist.Initial = contact.Initial;
                contactExist.CellNumber = contact.CellNumber;
                contactExist.CellNumberConfirmed = contact.CellNumberConfirmed;
                contactExist.WebName = contact.WebName;
                contactExist.ContactTitle = contact.ContactTitle;
                contactExist.IsAdmin = contact.IsAdmin;
                contactExist.EmailValidated = contact.EmailValidated;
                contactExist.Disabled = contact.Disabled;
                contactExist.IsNew = contact.IsNew;
                contactExist.SamplingPlanner_ProvincesTVItemID = contact.SamplingPlanner_ProvincesTVItemID;
                contactExist.PasswordHash = contact.PasswordHash;
                contactExist.Token = contact.Token;
                contactExist.AccessFailedCount = contact.AccessFailedCount;
                contactExist.LastUpdateDate_UTC = contact.LastUpdateDate_UTC;
                contactExist.LastUpdateContactTVItemID = contact.LastUpdateContactTVItemID;

                db.Contacts.Add(contactExist);
            }
            else
            {
                contactExist.ContactID = contact.ContactID;
                contactExist.DBCommand = contact.DBCommand;
                contactExist.Id = contact.Id;
                contactExist.ContactTVItemID = contact.ContactTVItemID;
                contactExist.LoginEmail = contact.LoginEmail;
                contactExist.FirstName = contact.FirstName;
                contactExist.LastName = contact.LastName;
                contactExist.Initial = contact.Initial;
                contactExist.CellNumber = contact.CellNumber;
                contactExist.CellNumberConfirmed = contact.CellNumberConfirmed;
                contactExist.WebName = contact.WebName;
                contactExist.ContactTitle = contact.ContactTitle;
                contactExist.IsAdmin = contact.IsAdmin;
                contactExist.EmailValidated = contact.EmailValidated;
                contactExist.Disabled = contact.Disabled;
                contactExist.IsNew = contact.IsNew;
                contactExist.SamplingPlanner_ProvincesTVItemID = contact.SamplingPlanner_ProvincesTVItemID;
                contactExist.PasswordHash = contact.PasswordHash;
                contactExist.Token = contact.Token;
                contactExist.AccessFailedCount = contact.AccessFailedCount;
                contactExist.LastUpdateDate_UTC = contact.LastUpdateDate_UTC;
                contactExist.LastUpdateContactTVItemID = contact.LastUpdateContactTVItemID;
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "";
        }
        #endregion Functions public

        #region Functions private
        #endregion Functions private
    }
}
