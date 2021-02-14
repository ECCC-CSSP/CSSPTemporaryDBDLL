using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPTemporaryDBDLL.Services
{
    public partial class TVItemUserAuthorizationTemporaryService
    {
        #region Variables
        #endregion Variables

        #region Properties
        CSSPTemporaryDBEntities db { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemUserAuthorizationTemporaryService()
        {
            db = new CSSPTemporaryDBEntities();
        }
        #endregion Constructors

        #region Functions public
        public string TVItemUserAuthorizationAddOrModify(List<TVItemUserAuthorization> tvItemUserAuthorizationList)
        {
            foreach (TVItemUserAuthorization tvItemUserAuthorization in tvItemUserAuthorizationList)
            {
                TVItemUserAuthorization tvItemUserAuthorizationExist = (from c in db.TVItemUserAuthorizations
                                                                        where c.TVItemUserAuthorizationID == tvItemUserAuthorization.TVItemUserAuthorizationID
                                                                        select c).FirstOrDefault();

                if (tvItemUserAuthorizationExist == null)
                {
                    tvItemUserAuthorizationExist = new TVItemUserAuthorization();
                    tvItemUserAuthorizationExist.TVItemUserAuthorizationID = tvItemUserAuthorization.TVItemUserAuthorizationID;
                    tvItemUserAuthorizationExist.DBCommand = tvItemUserAuthorization.DBCommand;
                    tvItemUserAuthorizationExist.ContactTVItemID = tvItemUserAuthorization.ContactTVItemID;
                    tvItemUserAuthorizationExist.TVItemID1 = tvItemUserAuthorization.TVItemID1;
                    tvItemUserAuthorizationExist.TVItemID2 = tvItemUserAuthorization.TVItemID2;
                    tvItemUserAuthorizationExist.TVItemID3 = tvItemUserAuthorization.TVItemID3;
                    tvItemUserAuthorizationExist.TVItemID4 = tvItemUserAuthorization.TVItemID4;
                    tvItemUserAuthorizationExist.TVAuth = tvItemUserAuthorization.TVAuth;
                    tvItemUserAuthorizationExist.LastUpdateDate_UTC = tvItemUserAuthorization.LastUpdateDate_UTC;
                    tvItemUserAuthorizationExist.LastUpdateContactTVItemID = tvItemUserAuthorization.LastUpdateContactTVItemID;

                    db.TVItemUserAuthorizations.Add(tvItemUserAuthorizationExist);
                }
                else
                {
                    tvItemUserAuthorizationExist.TVItemUserAuthorizationID = tvItemUserAuthorization.TVItemUserAuthorizationID;
                    tvItemUserAuthorizationExist.DBCommand = tvItemUserAuthorization.DBCommand;
                    tvItemUserAuthorizationExist.ContactTVItemID = tvItemUserAuthorization.ContactTVItemID;
                    tvItemUserAuthorizationExist.TVItemID1 = tvItemUserAuthorization.TVItemID1;
                    tvItemUserAuthorizationExist.TVItemID2 = tvItemUserAuthorization.TVItemID2;
                    tvItemUserAuthorizationExist.TVItemID3 = tvItemUserAuthorization.TVItemID3;
                    tvItemUserAuthorizationExist.TVItemID4 = tvItemUserAuthorization.TVItemID4;
                    tvItemUserAuthorizationExist.TVAuth = tvItemUserAuthorization.TVAuth;
                    tvItemUserAuthorizationExist.LastUpdateDate_UTC = tvItemUserAuthorization.LastUpdateDate_UTC;
                    tvItemUserAuthorizationExist.LastUpdateContactTVItemID = tvItemUserAuthorization.LastUpdateContactTVItemID;
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
