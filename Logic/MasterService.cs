using System;
using System.Linq;

namespace Logic
{
    public class MasterService : IMasterService
    {
        private readonly IAlgoService _algoService;

        private readonly IDataService _dataService;
        
        public MasterService(IAlgoService algo, IDataService data)
        {
            _algoService = algo;
            _dataService = data;
        }

        public int GetDoubleSum()
        {
            try
            {
                _dataService.GetAllData();
            }
            catch (NullReferenceException)
            {
                throw new InvalidOperationException("We have no data to process");
            }

            var data = _dataService.GetAllData();

            if (!data.Any())
            {
                throw new InvalidOperationException("We have no data to process");
            }

            return _algoService.DoubleSum(data);;
        }
        
        public double GetAverage()
        {
            var data = _dataService.GetAllData();
            return _algoService.GetAverage(data);
        }

        public double GetMaxSquare()
        {
            var data = _dataService.GetMax();
            return _algoService.Sqr(data);
        }
        public double GetMinSqure()
        {
            var data = _dataService.GetAllData();
            return _algoService.Sqr(_algoService.MinValue(data));
        }

        public double GetFunction()
        {
            var data = _dataService.GetAllData();
            var doubleSum = _algoService.DoubleSum(data);
            var min = _algoService.MinValue(data);
            var average = _algoService.GetAverage(data);
            var sqr = _algoService.Sqr(_dataService.ItemsCount);
            return _algoService.Function(min, average, doubleSum, sqr);
        }
    }
}