using mrr22023;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

using (var db = new AppDbcontext())
{
    var flatRepo = new ZavodRepository(db);
    Console.WriteLine($"всі дані");
    var flatA = flatRepo.GetAll();
    foreach (Zavod item in flatA)
    {
        Console.WriteLine($"{item.Number} ,{item.Position} ,{item.Expirience},{item.Salary},{item.Surname}");
    }

}
