using BankSystem.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Mvc.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RequirementCredit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequirementCredit(RequirementCredit requirementCredit)
        {
            if (ModelState.IsValid)
            {
                int amountOfNeedRequirement = requirementCredit.AmountOfNeedRequirementCredit;
                int monthlyPayment = requirementCredit.MonthlyPaymentRequirementCredit;

                if (monthlyPayment <= 12)
                {
                    double interestRate;

                    if (amountOfNeedRequirement > 0 && amountOfNeedRequirement <= 15000)
                    {
                        interestRate = 0.0212;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedRequirement * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedRequirement;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;
                      }
                    else if (amountOfNeedRequirement > 15000 &&  amountOfNeedRequirement <= 25000)
                    {
                        interestRate = 0.0209;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedRequirement * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedRequirement;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;

                    }
                    else if (amountOfNeedRequirement > 25000 &&  amountOfNeedRequirement <= 45000)
                    {
                        interestRate = 0.0208;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedRequirement * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedRequirement;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;

                    }
                    else if (amountOfNeedRequirement > 45000 &&  amountOfNeedRequirement <= 50000)
                    {
                        interestRate = 0.0207;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedRequirement * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedRequirement;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;

                    }
                    else if (amountOfNeedRequirement > 50000 &&  amountOfNeedRequirement <= 75000)
                    {
                        interestRate = 0.0206;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedRequirement * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedRequirement;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;

                    }
                    else if (amountOfNeedRequirement > 75000 &&  amountOfNeedRequirement <= 100000)
                    {
                        interestRate = 0.0200;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedRequirement * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedRequirement;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;

                    }
                    else if (amountOfNeedRequirement> 100000 && amountOfNeedRequirement <= 200000)
                    {
                        interestRate = 0.0198;
                        double percentageInterestRate = Math.Round((interestRate * 100),2);
                        double InterestEarning = amountOfNeedRequirement * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment),2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedRequirement;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;

                    }
                    return View();
                }
                return View(requirementCredit);
            }
            return View(requirementCredit);
          
        }


        [HttpGet]
        public IActionResult HomeCredit()
        {
            return View();    
        }


        [HttpPost]
        public IActionResult HomeCredit(HomeCredit homeCredit)
        {
            if (ModelState.IsValid)
            {
                int monthlyPayment = homeCredit.MonthlyPaymentHomeCredit;
                int amountOfNeedHomeCredit = homeCredit.AmountOfNeedHomeCredit;
                if ( monthlyPayment>0 && monthlyPayment < 120)
                {
                    double interestRate;
                    if (amountOfNeedHomeCredit > 0 && amountOfNeedHomeCredit <= 150000)
                    {
                        interestRate = 0.0203;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedHomeCredit * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedHomeCredit;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;
                    }
                    else if (amountOfNeedHomeCredit > 0 && amountOfNeedHomeCredit <= 750000)
                    {
                        interestRate = 0.0199;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedHomeCredit * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedHomeCredit;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;
                    }
                    else if (amountOfNeedHomeCredit > 0 && amountOfNeedHomeCredit <= 750000)
                    {
                        interestRate = 0.0199;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedHomeCredit * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedHomeCredit;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;
                    }
                    else if (amountOfNeedHomeCredit > 0 && amountOfNeedHomeCredit <= 3000000)
                    {
                        interestRate = 0.0199;
                        double percentageInterestRate = Math.Round((interestRate * 100), 2);
                        double InterestEarning = amountOfNeedHomeCredit * interestRate * monthlyPayment;
                        double InstallmentAmount = Math.Round((InterestEarning / monthlyPayment), 2);
                        TempData["MonthlyPayment"] = monthlyPayment;
                        TempData["amountOfNeedRequirement"] = amountOfNeedHomeCredit;
                        TempData["interestRate"] = percentageInterestRate;
                        TempData["InstallmentAmount"] = InstallmentAmount;
                        TempData["InterestEarning"] = InterestEarning;
                    }
                    return View();

                }
                return View(homeCredit);
            }
            return View(homeCredit);
        }


        [HttpGet]
        public IActionResult VehicleCredit()
        {
            return View();
        }


        [HttpPost]
        public IActionResult VehicleCredit(VehicleCredit vehicleCredit )
        {

            if (ModelState.IsValid)
            {
                int monthlyPaymentVehicleCredit = vehicleCredit.MonthlyPaymentVehicleCredit;
                int amountOfNeedVehicleCredit = vehicleCredit.AmountOfNeedVehicleCredit;
                double interestRate;

                if (vehicleCredit.MonthlyPaymentVehicleCredit <= 30 && vehicleCredit.MonthlyPaymentVehicleCredit >0)
                {
                   

                    interestRate = 0.0203;
                    double percentageInterestRate = Math.Round((interestRate * 100), 2);
                    double InterestEarning = amountOfNeedVehicleCredit * interestRate * monthlyPaymentVehicleCredit;
                    double InstallmentAmount = Math.Round((InterestEarning / monthlyPaymentVehicleCredit), 2);
                    TempData["MonthlyPayment"] = monthlyPaymentVehicleCredit;
                    TempData["amountOfNeedRequirement"] = amountOfNeedVehicleCredit;
                    TempData["interestRate"] = percentageInterestRate;
                    TempData["InstallmentAmount"] = InstallmentAmount;
                    TempData["InterestEarning"] = InterestEarning;
                }
                else if (vehicleCredit.MonthlyPaymentVehicleCredit <= 48 && vehicleCredit.MonthlyPaymentVehicleCredit > 0)
                {
                    interestRate = 0.0229;
                    double percentageInterestRate = Math.Round((interestRate * 100), 2);
                    double InterestEarning = amountOfNeedVehicleCredit * interestRate * monthlyPaymentVehicleCredit;
                    double InstallmentAmount = Math.Round((InterestEarning / monthlyPaymentVehicleCredit), 2);
                    TempData["MonthlyPayment"] = monthlyPaymentVehicleCredit;
                    TempData["amountOfNeedRequirement"] = amountOfNeedVehicleCredit;
                    TempData["interestRate"] = percentageInterestRate;
                    TempData["InstallmentAmount"] = InstallmentAmount;
                    TempData["InterestEarning"] = InterestEarning;
                }
                return View();
            }

            return View(vehicleCredit);
        }


    }
}
