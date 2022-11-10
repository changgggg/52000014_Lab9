using StudentServiceLib;
namespace StudentTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void Score8_Should_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Score7AndHalf_Should_ReturnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 7.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score7_Should_ReturnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score6dot5_Should_ReturnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 6.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }


        [TestMethod]
        public void Score5_Should_ReturnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }


        [TestMethod]
        public void Score3dot5_Should_ReturnD()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void Score3_Should_ReturnE()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 3;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        public void addFirstStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 1, Name = "Toan", Age = 30, Score = 9 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1,size);
        }


    }
}