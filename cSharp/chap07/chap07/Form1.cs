using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //클래스는 이게 없기때문에  mbox가 System.Windows.Forms.MessageBox.Show()이런식으로 나옴

namespace chap07
{
    public partial class Form1 : Form
    {
        List<Dog> Dogs = new List<Dog>()
            { new Dog(), new Dog()};
        List<Cat> Cats = new List<Cat>()
            { new Cat(), new Cat()};

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Dogs)
            {
                item.Eat();
                item.Bark();
            }
            foreach(var item in Cats)
            {
                item.Eat();
                item.Meow();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (false)
            {
                NewCat c = new NewCat();
                c.Eat();  //상속받았기때문에 newcat에는 이게 없지만 가져올수있음
                c.name = "이동준";
                c.breedName = "인간";
                NewDog d = new NewDog();
                d.Eat();
            }
           

            List<Animal> Animals = new List<Animal>()
            {//다형성:다양한 형태 가질수있음 animal이 부모클래스. 따라서 animal타입을 저장하는 리스트인데 
                new NewDog(), new NewCat(), new NewDog(), new NewCat()  //얘네가 animal이랑 부자관계라서 animal타입이 아닌데도 형변환 가능함
            }; //부자의 관계가 확실하면 형변환이 가능하다 a(newdog) is b(animal). newdog가 animal이기때문에 가능
           // (Animals[0] as NewDog).breedName = "말티즈";

            foreach(var item in Animals)
            {
                item.Eat();
                var dog = item as NewDog;  //호
                if (dog != null)
                {
                    dog.Bark();
                }
                var cat = item as NewCat;
                if (cat != null)
                {
                    cat.Meow();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//오버라이딩=재정의
            Animal a = new Animal();
            NewCat c = new NewCat();
            NewDog d = new NewDog();

            a.Fight();
            d.Fight();
            c.Fight();

            a.name = "이동준";
            a.age = 20;

            d.name = "니니";
            d.age = 17;

            MessageBox.Show(a.ToString());
            MessageBox.Show(d.ToString());

            Cat oldcat = new Cat();
            oldcat.name = "냐옹";
            oldcat.age = 25;
            MessageBox.Show(oldcat.ToString());
        }
    }
}
