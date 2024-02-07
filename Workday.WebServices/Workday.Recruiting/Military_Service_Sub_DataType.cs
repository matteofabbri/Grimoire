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
	public class Military_Service_Sub_DataType : INotifyPropertyChanged
	{
		private Military_StatusObjectType military_Status_ReferenceField;

		private DateTime military_Discharge_DateField;

		private bool military_Discharge_DateFieldSpecified;

		private DateTime military_Status_Begin_DateField;

		private bool military_Status_Begin_DateFieldSpecified;

		private Military_Service_TypeObjectType military_Service_Type_ReferenceField;

		private Military_RankObjectType military_Rank_ReferenceField;

		private string notesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Military_StatusObjectType Military_Status_Reference
		{
			get
			{
				return this.military_Status_ReferenceField;
			}
			set
			{
				this.military_Status_ReferenceField = value;
				this.RaisePropertyChanged("Military_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Military_Discharge_Date
		{
			get
			{
				return this.military_Discharge_DateField;
			}
			set
			{
				this.military_Discharge_DateField = value;
				this.RaisePropertyChanged("Military_Discharge_Date");
			}
		}

		[XmlIgnore]
		public bool Military_Discharge_DateSpecified
		{
			get
			{
				return this.military_Discharge_DateFieldSpecified;
			}
			set
			{
				this.military_Discharge_DateFieldSpecified = value;
				this.RaisePropertyChanged("Military_Discharge_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Military_Status_Begin_Date
		{
			get
			{
				return this.military_Status_Begin_DateField;
			}
			set
			{
				this.military_Status_Begin_DateField = value;
				this.RaisePropertyChanged("Military_Status_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Military_Status_Begin_DateSpecified
		{
			get
			{
				return this.military_Status_Begin_DateFieldSpecified;
			}
			set
			{
				this.military_Status_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Military_Status_Begin_DateSpecified");
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
