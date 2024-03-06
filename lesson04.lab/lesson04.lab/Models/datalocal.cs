namespace lesson04.lab.Models
{
    public class datalocal
    {
        public static List<people> _peoples = new List<people>()
        {
            new people() { id = "0", name = "thanh tung", email = "tung@gmail.com", phone = "0976727372", adress = "39 nguyen dinh chieu", avatar = "/images/avatar/1.jpg", bio = "hpg" },
            new people() { id = "1", name = "abc",email="abc@gmail.com, phone = "1234567890", adress = "hanoi", avatar = "/images/avatar/2/jpg,", bio = "abcxyz", email = "abc@gmail.com" },
            new people() { id = "3", name = "mina", phone = "0987654321", adress = "vinhome", avatar = "/images/avatar/3.jpg", bio = "mina", email = "mina@gmail.com" },


        };
    };
    //getpeoples(:lay du lieu danh sach peoples:
    public static List<people> GetPeoples()
    {
        var peoples= _peoples.
    }
    //getpeoplebyid:lay du lieu people theo id:
    public static people? GetPeoplebyid(int id)
    {
        var people = _peoples.firstordefault(x => x.id == id);
        return people;
.

    

    }
