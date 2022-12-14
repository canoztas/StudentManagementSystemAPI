using StudentManagementSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystemAPI.Data
{
    public class UserStore
    {
        public static List<User> userList = new List<User>
        {
            new User{UserId=1,FirstName="Jon",LastName="Snow",Email="jonsnow@jon.com",PasswordHash="1",DepartmentId=1,PhotoPath="https://www.google.com/url?sa=i&url=https%3A%2F%2Ftr.wikipedia.org%2Fwiki%2FHermann_Rorschach&psig=AOvVaw3c4FQjTWFjehrs2eIhR1_g&ust=1671039943346000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCPDRvIST9_sCFQAAAAAdAAAAABAI",UserType="student",LessonId=new List<int>(){1,2} },
            new User{UserId=2,FirstName="Joe",LastName="Snow",Email="jonsnow@jon.com",PasswordHash="1",DepartmentId=1,PhotoPath="https://www.google.com/url?sa=i&url=https%3A%2F%2Ftr.wikipedia.org%2Fwiki%2FHermann_Rorschach&psig=AOvVaw3c4FQjTWFjehrs2eIhR1_g&ust=1671039943346000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCPDRvIST9_sCFQAAAAAdAAAAABAI",UserType="student",LessonId=new List<int>(){1,2} }
        };
    }
}
