using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Models
{
    class EMSDesktopClientInterface
    {
        private readonly static ApplicationDbContext context = new ApplicationDbContext();

        public static ApplicationDbContext Context
        {
            get { return context; }
        }

        #region Synchronous Methods

        #region Helper Methods

        private static void AddDeleteAction(dynamic entity)
        {
            int deletedBy = Context.Users.Where(u => u.Name == "Doctor").Single().ID;
            int deleteActionID = Context.ActionTypes.Where(at => at.Name == "Delete").Single().ID;
            entity.UserActions.Add(new UserAction()
            {
                ActionTypeID = deleteActionID,
                Date = DateTime.Now,
                UserID = deletedBy
            });
        }
        private static void AddUpdateAction(dynamic entity)
        {
            int updatedBy = Context.Users.Where(u => u.Name == "Doctor").Single().ID;
            int updateActionID = Context.ActionTypes.Where(at => at.Name == "Update").Single().ID;
            entity.UserActions.Add(new UserAction()
            {
                ActionTypeID = updateActionID,
                Date = DateTime.Now,
                UserID = updatedBy
            });
        }
        private static void AddCreateAction(dynamic entity)
        {
            int createdBy = Context.Users.Where(u => u.Name == "Doctor").Single().ID;
            int createActionID = Context.ActionTypes.Where(at => at.Name == "Create").Single().ID;
            entity.UserActions.Add(new UserAction()
            {
                ActionTypeID = createActionID,
                Date = DateTime.Now,
                UserID = createdBy
            });
        }

        #endregion

        #region Retrieval Methods

        

        #endregion

        #region Insertion Methods

        

        #endregion

        #region Delete Methods

        

        #endregion

        #region Update Methods

        

        #endregion

        #endregion
    }
}
