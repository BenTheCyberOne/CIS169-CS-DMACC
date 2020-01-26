/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Polymorphism
 The user can click a button and create a standard animal, cat, or dog and be displayed information on the child class
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }
        private void ShowAnimalInfo(Animal animal)//show information on sent animal
        {
            MessageBox.Show("Species: " + animal._species);
            animal.makeSound();
        }
        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }

        private void createAnimalButton_Click(object sender, EventArgs e)//make an animal
        {
            Animal animal = new Animal("Regular Animal");
            ShowAnimalInfo(animal);
        }

        private void createDogButton_Click(object sender, EventArgs e)//make a dog object
        {
            Dog dog = new Dog("Fido");
            MessageBox.Show("My dog's name is: " + dog._name);
            ShowAnimalInfo(dog);
        }

        private void createCatButton_Click(object sender, EventArgs e)//make a cat object
        {
            Cat cat = new Cat("Kitty");
            MessageBox.Show("The cat's name is: " + cat._name);
            ShowAnimalInfo(cat);
        }
    }
}
