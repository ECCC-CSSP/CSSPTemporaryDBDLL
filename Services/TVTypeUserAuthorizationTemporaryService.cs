using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPTemporaryDBDLL.Services
{
    public partial class TVTypeUserAuthorizationTemporaryService
    {
        #region Variables
        #endregion Variables

        #region Properties
        CSSPTemporaryDBEntities db { get; set; }
        #endregion Properties

        #region Constructors
        public TVTypeUserAuthorizationTemporaryService()
        {
            db = new CSSPTemporaryDBEntities();
        }
        #endregion Constructors

        #region Functions public
        public string TVTypeUserAuthorizationAddOrModify(List<TVTypeUserAuthorization> tvTypeUserAuthorizationList)
        {
            foreach (TVTypeUserAuthorization tvTypeUserAuthorization in tvTypeUserAuthorizationList)
            {
                TVTypeUserAuthorization tvTypeUserAuthorizationExist = (from c in db.TVTypeUserAuthorizations
                                                                        where c.TVTypeUserAuthorizationID == tvTypeUserAuthorization.TVTypeUserAuthorizationID
                                                                        select c).FirstOrDefault();

                if (tvTypeUserAuthorizationExist == null)
                {
                    tvTypeUserAuthorizationExist = new TVTypeUserAuthorization();
                    tvTypeUserAuthorizationExist.TVTypeUserAuthorizationID = tvTypeUserAuthorization.TVTypeUserAuthorizationID;
                    tvTypeUserAuthorizationExist.DBCommand = tvTypeUserAuthorization.DBCommand;
                    tvTypeUserAuthorizationExist.ContactTVItemID = tvTypeUserAuthorization.ContactTVItemID;
                    tvTypeUserAuthorizationExist.TVType = tvTypeUserAuthorization.TVType;
                    tvTypeUserAuthorizationExist.TVAuth = tvTypeUserAuthorization.TVAuth;
                    tvTypeUserAuthorizationExist.LastUpdateDate_UTC = tvTypeUserAuthorization.LastUpdateDate_UTC;
                    tvTypeUserAuthorizationExist.LastUpdateContactTVItemID = tvTypeUserAuthorization.LastUpdateContactTVItemID;

                    db.TVTypeUserAuthorizations.Add(tvTypeUserAuthorization);
                }
                else
                {
                    tvTypeUserAuthorizationExist.TVTypeUserAuthorizationID = tvTypeUserAuthorization.TVTypeUserAuthorizationID;
                    tvTypeUserAuthorizationExist.DBCommand = tvTypeUserAuthorization.DBCommand;
                    tvTypeUserAuthorizationExist.ContactTVItemID = tvTypeUserAuthorization.ContactTVItemID;
                    tvTypeUserAuthorizationExist.TVType = tvTypeUserAuthorization.TVType;
                    tvTypeUserAuthorizationExist.TVAuth = tvTypeUserAuthorization.TVAuth;
                    tvTypeUserAuthorizationExist.LastUpdateDate_UTC = tvTypeUserAuthorization.LastUpdateDate_UTC;
                    tvTypeUserAuthorizationExist.LastUpdateContactTVItemID = tvTypeUserAuthorization.LastUpdateContactTVItemID;
                }

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            return "";
        }
        #endregion Functions public

        #region Functions private
        #endregion Functions private

    }
}
