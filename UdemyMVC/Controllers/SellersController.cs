using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
using UdemyMVC.Models;
using UdemyMVC.Models.ViewModels;
using UdemyMVC.Services;
using UdemyMVC.Services.Excepitons;
using UdemyMVC.Services.Exceptions;

namespace UdemyMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;
        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }
<<<<<<< HEAD
        public async Task<IActionResult> Index()
        {
            var list = await _sellerService.FindAllAsync();
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            var departments = await _departmentService.FindAllAsync();
=======
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            await _sellerService.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
=======
        public IActionResult Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var departments = _departmentService.FindAll();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
<<<<<<< HEAD
            var obj = await _sellerService.FindByIdAsync(id.Value);
=======
            var obj = _sellerService.FindById(id.Value);
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Delete(int id)
        {
            await _sellerService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
=======
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int? id)
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
<<<<<<< HEAD
            var obj = await _sellerService.FindByIdAsync(id.Value);
=======
            var obj = _sellerService.FindById(id.Value);
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            return View(obj);
        }
<<<<<<< HEAD
        public async Task<IActionResult> Edit(int? id)
=======
        public IActionResult Edit(int? id)
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
<<<<<<< HEAD
            var obj = await _sellerService.FindByIdAsync(id.Value);
=======
            var obj = _sellerService.FindById(id.Value);
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
<<<<<<< HEAD
            List<Department> departments = await _departmentService.FindAllAsync();
=======
            List<Department> departments = _departmentService.FindAll();
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(int id, Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindAllAsync();
=======
        public IActionResult Edit(int id, Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var departments = _departmentService.FindAll();
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
<<<<<<< HEAD
                await _sellerService.UpdateAsync(seller);
=======
                _sellerService.Update(seller);
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }


    }
}
