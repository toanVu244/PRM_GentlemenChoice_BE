using GentlemenChoice.Common;
using GentlemenChoice.Data;
using GentlemenChoice.Data.Models;
using GentlemenChoice.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice.Service
{
    public interface IUserService
    {
        Task<ServiceResult> GetAll();
        Task<ServiceResult> GetById(int UserId);
        Task<ServiceResult> Save(User user);
        Task<ServiceResult> DeleteById(int UserId);
    }

    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;

        public UserService() => _unitOfWork ??= new UnitOfWork();

        public async Task<ServiceResult> GetAll()
        {
            #region Business Rule

            #endregion Business Rule

            var users = await _unitOfWork.UserRepository.GetAllAsync();

            if (users == null)
            {
                return new ServiceResult(Const.WARNING_NO_DATA_CODE, Const.WARNING_NO_DATA_MSG);
            }
            else
            {
                return new ServiceResult(Const.SUCCESS_READ_CODE, Const.SUCCESS_READ_MSG, users);
            }
        }

        public async Task<ServiceResult> GetById(int UserId)
        {
            #region Business Rule

            #endregion Business Rule

            var user = await _unitOfWork.UserRepository.GetByIdAsync(UserId);
            if (user == null)
            {
                return new ServiceResult(Const.WARNING_NO_DATA_CODE, Const.WARNING_NO_DATA_MSG);
            }
            else
            {
                return new ServiceResult(Const.SUCCESS_READ_CODE, Const.SUCCESS_READ_MSG, user);
            }
        }

        public async Task<ServiceResult> Save(User user)
        {
            try
            {
                #region Business Rule

                #endregion Business Rule

                int result = -1;

                var userTmp = _unitOfWork.UserRepository.GetById(user.UserId);

                if (userTmp != null)
                {
                    result = await _unitOfWork.UserRepository.UpdateAsync(user);

                    if (result > 0)
                    {
                        return new ServiceResult(Const.SUCCESS_UPDATE_CODE, Const.SUCCESS_UPDATE_MSG, user);
                    }
                    else
                    {
                        return new ServiceResult(Const.FAIL_UPDATE_CODE, Const.FAIL_UPDATE_MSG);
                    }
                }
                else
                {
                    result = await _unitOfWork.UserRepository.CreateAsync(user);

                    if (result > 0)
                    {
                        return new ServiceResult(Const.SUCCESS_CREATE_CODE, Const.SUCCESS_CREATE_MSG, user);
                    }
                    else
                    {
                        return new ServiceResult(Const.FAIL_CREATE_CODE, Const.FAIL_CREATE_MSG, user);
                    }
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult(Const.ERROR_EXCEPTION, ex.ToString());
            }
        }

        public async Task<ServiceResult> DeleteById(int UserId)
        {
            try
            {
                var result = false;
                var userResult = this.GetById(UserId);

                if (userResult != null && userResult.Result.Status == Const.SUCCESS_READ_CODE)
                {
                    result = await _unitOfWork.UserRepository.RemoveAsync((User)userResult.Result.Data);

                    if (result)
                    {
                        return new ServiceResult(Const.SUCCESS_DELETE_CODE, Const.SUCCESS_DELETE_MSG, result);
                    }
                    else
                    {
                        return new ServiceResult(Const.FAIL_DELETE_CODE, Const.FAIL_DELETE_MSG, userResult.Result.Data);
                    }
                }
                else
                {
                    return new ServiceResult(Const.WARNING_NO_DATA_CODE, Const.WARNING_NO_DATA_MSG);
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult(Const.ERROR_EXCEPTION, ex.ToString());
            }
        }
    }
}
