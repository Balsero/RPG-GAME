using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged 
    {
        private Location _currentLocation;
        

        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation 
        {
            get { return _currentLocation; }
            set 
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToSouth");
                OnPropertyChanged("HasLocationToWest");
            
            }
            
            
        }

        public bool HasLocationToNorth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public World CurrentWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Nekrogoblin";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(0, 2);


        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveEast()

        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate );

        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);

        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
