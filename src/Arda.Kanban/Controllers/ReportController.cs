﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Arda.Common.ViewModels.Reports;
using Arda.Common.Interfaces.Kanban;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Arda.Kanban.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        IReportRepository _repository;

        public ReportController(IReportRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getactivityconsumingdata")]
        public IEnumerable<ActivityConsumingViewModel> GetActivityConsumingData([FromQuery]DateTime startDate, [FromQuery] DateTime endDate, [FromQuery]string user = "All")
        {
            try
            {
                var activities = _repository.GetActivityConsumingData(startDate, endDate, user);

                if (activities != null)
                {
                    return activities;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("getexpertiseconsumingdata")]
        public IEnumerable<ExpertiseConsumingViewModel> GetExpertiseConsumingData([FromQuery]DateTime startDate, [FromQuery]DateTime endDate, [FromQuery]string user = "All")
        {
            try
            {
                var expertises = _repository.GetExpertiseConsumingData(startDate, endDate, user);

                if (expertises != null)
                {
                    return expertises;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("getmetricconsumingdata")]
        public IEnumerable<MetricConsumingViewModel> GetMetricConsumingData([FromQuery]DateTime startDate, [FromQuery]DateTime endDate, [FromQuery]string user = "All")
        {
            try
            {
                var metrics = _repository.GetMetricConsumingData(startDate, endDate, user);

                if (metrics != null)
                {
                    return metrics;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
