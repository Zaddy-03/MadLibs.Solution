using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Collections.Generic;
using System;
using MadLib.Models;

namespace MadLib.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/form")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/story")]
        public ActionResult Story(string name, string anotherName, string animal, string exclamation, string verb, string noun)
        {
            FormVariable formVariable = new FormVariable();
            formVariable.Name = name;
            formVariable.AnotherName = anotherName;
            formVariable.Animal = animal;
            formVariable.Exclamation = exclamation;
            formVariable.PastTenseVerb = verb;
            formVariable.Noun = noun;
            return View(formVariable);
        }

        [Route("/anotherform")]
        public ActionResult AnotherForm()
        {
            return View();
        }

        [Route("/anotherstory")]
        public ActionResult AnotherStory(string Ajective, string food1, string Verb, string Saying, string Noun, string food2, string Color, string Something, string Animal, string Person)
        {
            AnotherFormVariable anotherFormVariable = new AnotherFormVariable();
            anotherFormVariable.Ajective = Ajective;
            anotherFormVariable.food1 = food1;
            anotherFormVariable.Verb = Verb;
            anotherFormVariable.Saying = Saying;
            anotherFormVariable.Nouns = Noun;
            anotherFormVariable.food2 = food2;
            anotherFormVariable.Color = Color;
            anotherFormVariable.Something = Something;
            anotherFormVariable.Animals = Animal;
            anotherFormVariable.Person = Person;

            return View(anotherFormVariable);
        }

    }
}