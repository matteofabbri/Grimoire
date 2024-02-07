using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Local_Person_Name_DataType : INotifyPropertyChanged
	{
		private string first_Name__LocalField;

		private string last_Name__LocalField;

		private string first_Name_2__LocalField;

		private string last_Name_2__LocalField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("First_Name_-_Local", Order = 0)]
		public string First_Name__Local
		{
			get
			{
				return this.first_Name__LocalField;
			}
			set
			{
				this.first_Name__LocalField = value;
				this.RaisePropertyChanged("First_Name__Local");
			}
		}

		[XmlElement("Last_Name_-_Local", Order = 1)]
		public string Last_Name__Local
		{
			get
			{
				return this.last_Name__LocalField;
			}
			set
			{
				this.last_Name__LocalField = value;
				this.RaisePropertyChanged("Last_Name__Local");
			}
		}

		[XmlElement("First_Name_2_-_Local", Order = 2)]
		public string First_Name_2__Local
		{
			get
			{
				return this.first_Name_2__LocalField;
			}
			set
			{
				this.first_Name_2__LocalField = value;
				this.RaisePropertyChanged("First_Name_2__Local");
			}
		}

		[XmlElement("Last_Name_2_-_Local", Order = 3)]
		public string Last_Name_2__Local
		{
			get
			{
				return this.last_Name_2__LocalField;
			}
			set
			{
				this.last_Name_2__LocalField = value;
				this.RaisePropertyChanged("Last_Name_2__Local");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
