using SmartTeleHealth.Data.Repositories;
using SmartTeleHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeleHealth.Data.Services
{
    public interface IStateService
    {
        IEnumerable<State> GetStates();
        State GetState(int id);
        int SaveState(State state);

        int UpdateState(State state);

    }
    public class StateService : IStateService
    {
        private readonly IStateRepository stateRepository;

        public StateService(IStateRepository stateRepository)
        {
            this.stateRepository = stateRepository;
        }

        public State GetState(int id)
        {
            return stateRepository.Get(id);
        }

        public IEnumerable<State> GetStates()
        {
            return stateRepository.GetAll();
        }

        public int SaveState(State state)
        {
            this.stateRepository.Add(state);
            return this.stateRepository.SaveChanges();
        }

        public int UpdateState(State state)
        {
            this.stateRepository.Update(state);
            return this.stateRepository.SaveChanges();
        }

    }
}
