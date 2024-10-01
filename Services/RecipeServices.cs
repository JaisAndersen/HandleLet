using Microsoft.AspNetCore.Identity;

namespace HandleLet.Services
{
    public class RecipeServices
    {
        public List<Recipe> userStories;

        public UserStoryService()
        {
            userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }

        public UserStory GetUserStory(int Id)
        {
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == Id)
                    return userStory;
            }

            return null;
        }
        public UserStory DeleteUserStory(int userstoryId)
        {
            UserStory userstoryToBeDeleted = null;
            foreach (UserStory us in userStories)
            {
                if (us.Id == userstoryId)
                {
                    userstoryToBeDeleted = us;
                    break;
                }
            }
            if (userstoryToBeDeleted != null)
            {
                userStories.Remove(userstoryToBeDeleted);
            }
            return userstoryToBeDeleted;
        }


        public void CreateUserStory(UserStory userStory)
        {

            userStories.Add(userStory);

        }









    }
}
