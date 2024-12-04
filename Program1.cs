
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

List<Order> repo = new List<Order>();
{
    new Order(23, 2012,"машина" , "f", "ошибка", "черемнов кирилл евгеньевич", 8965643, 1);
}
app.MapGet("/{id}", (int id) => repo[id]);
app.MapPost

class Order
{
    int Number;
    int data_dabav;
    string tehnica;
    string model;
    string problema;
    string name;
    int number_phone;
    int statys;

    public int Number1 { get => Number; set => Number = value; }
    public int Data_dabav { get => data_dabav; set => data_dabav = value; }
    public string Tehnica { get => tehnica; set => tehnica = value; }
    public string Model { get => model; set => model = value; }
    public string Problema { get => problema; set => problema = value; }
    public string Name { get => name; set => name = value; }
    public int Number_phone { get => number_phone; set => number_phone = value; }
    public int Statys { get => statys; set => statys = value; }
}
