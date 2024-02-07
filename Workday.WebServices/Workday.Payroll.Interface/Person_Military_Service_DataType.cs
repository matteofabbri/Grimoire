using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Person_Military_Service_DataType : INotifyPropertyChanged
	{
		private Military_StatusObjectType status_ReferenceField;

		private DateTime discharge_DateField;

		private bool discharge_DateFieldSpecified;

		private DateTime status_Begin_DateField;

		private bool status_Begin_DateFieldSpecified;

		private Military_Service_TypeObjectType military_Service_Type_ReferenceField;

		private Military_RankObjectType military_Rank_ReferenceField;

		private string notesField;

		private Military_Service_ReferenceObjectType military_Service_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Military_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Discharge_Date
		{
			get
			{
				return this.discharge_DateField;
			}
			set
			{
				this.discharge_DateField = value;
				this.RaisePropertyChanged("Discharge_Date");
			}
		}

		[XmlIgnore]
		public bool Discharge_DateSpecified
		{
			get
			{
				return this.discharge_DateFieldSpecified;
			}
			set
			{
				this.discharge_DateFieldSpecified = value;
				this.RaisePropertyChanged("Discharge_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Status_Begin_Date
		{
			get
			{
				return this.status_Begin_DateField;
			}
			set
			{
				this.status_Begin_DateField = value;
				this.RaisePropertyChanged("Status_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Status_Begin_DateSpecified
		{
			get
			{
				return this.status_Begin_DateFieldSpecified;
			}
			set
			{
				this.status_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Status_Begin_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Military_Service_TypeObjectType Military_Service_Type_Reference
		{
			get
			{
				return this.military_Service_Type_ReferenceField;
			}
			set
			{
				this.military_Service_Type_ReferenceField = value;
				this.RaisePropertyChanged("Military_Service_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Military_RankObjectType Military_Rank_Reference
		{
			get
			{
				return this.military_Rank_ReferenceField;
			}
			set
			{
				this.military_Rank_ReferenceField = value;
				this.RaisePropertyChanged("Military_Rank_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
			}
		}

		[XmlElement(Order = 6)]
		public Military_Service_ReferenceObjectType Military_Service_Reference
		{
			get
			{
				return this.military_Service_ReferenceField;
			}
			set
			{
				this.military_Service_ReferenceField = value;
				this.RaisePropertyChanged("Military_Service_Reference");
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
