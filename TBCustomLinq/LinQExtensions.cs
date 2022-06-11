using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBCustomLinq;
public static class LinQExtensions
{

    public static IEnumerable<UserModel> TBWhere_EvenId(this IEnumerable<UserModel> users)
    {
        var result = new List<UserModel>();

        foreach (var user in users)
        {
            if (user.Id % 2 == 0)
                result.Add(user);
        }

        return result;
    }

    public static IEnumerable<UserModel> TBWhere_GmailUsers(this IEnumerable<UserModel> users)
    {
        var result = new List<UserModel>();

        foreach (var user in users)
        {
            if (user.EmailAddress.EndsWith("gmail.com"))
                result.Add(user);
        }

        return result;
    }

    public static UserModel TBFirstOrDefault(this IEnumerable<UserModel> users)
    {
        foreach (var user in users)
        {
            return user;
        }

        return null;
    }

    public static UserModel TBFirstOrDefault_FirstNameLengthGreater4(this IEnumerable<UserModel> users)
    {
        foreach (var user in users)
        {
            if (user.FirstName.Length > 4)
                return user;
        }

        return null;
    }

    public static List<UserModel> TBToList(this IEnumerable<UserModel> users)
    {
        var result = new List<UserModel>();

        foreach (var user in users)
        {
            result.Add(user);
        }

        return result;
    }

}
