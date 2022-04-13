using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class GroupService : IGroup
    {
        public static int Count { get; set; }
        private GroupRepository _groupRepository;
        public GroupService()
        {
            _groupRepository = new GroupRepository();
        }

        public Group Create(Group group)

        {
            group.Id = Count;

            _groupRepository.Create(group);
            Count++;
            return group;
            
        }

        public Group Delete(int Id)
        {
            Group isExist = _groupRepository.GetOne(g => g.Id == Id);
            if (isExist==null)
            {
                return null;
            }
            _groupRepository.Delete(isExist);
            return isExist;
        }

        public Group GetGroup(string name)
        {
            return _groupRepository.GetOne(g=>g.Name==name);
        }

        

        public List<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }

        public Group GetGroup(int id)
        {
            return _groupRepository.GetOne(g => g.Id == id);
        }

        public List<Group> GetAll(string name = null)
        {
            throw new NotImplementedException();
        }

        public Group Update(int id, Group group)
        {
            throw new NotImplementedException();
        }
    }
}
