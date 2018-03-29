using Blog.Data.Infrastructure;
using Blog.Data.Repositories;
using Blog.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    internal class ErrorService : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWord)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWord;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}