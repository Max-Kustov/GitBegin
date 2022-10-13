﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp;

namespace TodoApp.Models
{
    internal class TodoModel:INotifyPropertyChanged
    {
		[JsonProperty(PropertyName = "creationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
		private bool _isDone;
        private string _text;

		public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(PropertyName = "isDone")]
        public bool IsDone
		{
			get { return _isDone; }
			set 
			{
				if (_isDone == value)
					return;
                    
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
		}

        [JsonProperty(PropertyName = "text")]
        public string Text
		{
			get { return _text; }
			set 
			{
				if (_text == value)
					return ;

				_text = value;
				OnPropertyChanged("Text");
			}
		}
		protected virtual void OnPropertyChanged(string propertyName= "")
		{
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //проверка на null и передачав событие имя свойства,которое было изменено
		}
	}
}
