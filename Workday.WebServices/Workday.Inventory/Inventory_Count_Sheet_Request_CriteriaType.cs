using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Count_Sheet_Request_CriteriaType : INotifyPropertyChanged
	{
		private LocationObjectType[] inventory_Sites_ReferenceField;

		private string count_Sheet_NumberField;

		private DateTime count_Sheet_Created_On_or_AfterField;

		private bool count_Sheet_Created_On_or_AfterFieldSpecified;

		private DateTime count_Sheet_Created_On_or_BeforeField;

		private bool count_Sheet_Created_On_or_BeforeFieldSpecified;

		private Document_StatusObjectType[] count_Sheet_Statuses_ReferenceField;

		private WorkerObjectType[] assigned_To_Workers_ReferenceField;

		private bool exclude_CancelledField;

		private bool exclude_CancelledFieldSpecified;

		private bool exclude_ClosedField;

		private bool exclude_ClosedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Sites_Reference", Order = 0)]
		public LocationObjectType[] Inventory_Sites_Reference
		{
			get
			{
				return this.inventory_Sites_ReferenceField;
			}
			set
			{
				this.inventory_Sites_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Sites_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Count_Sheet_Number
		{
			get
			{
				return this.count_Sheet_NumberField;
			}
			set
			{
				this.count_Sheet_NumberField = value;
				this.RaisePropertyChanged("Count_Sheet_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Count_Sheet_Created_On_or_After
		{
			get
			{
				return this.count_Sheet_Created_On_or_AfterField;
			}
			set
			{
				this.count_Sheet_Created_On_or_AfterField = value;
				this.RaisePropertyChanged("Count_Sheet_Created_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Count_Sheet_Created_On_or_AfterSpecified
		{
			get
			{
				return this.count_Sheet_Created_On_or_AfterFieldSpecified;
			}
			set
			{
				this.count_Sheet_Created_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Count_Sheet_Created_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Count_Sheet_Created_On_or_Before
		{
			get
			{
				return this.count_Sheet_Created_On_or_BeforeField;
			}
			set
			{
				this.count_Sheet_Created_On_or_BeforeField = value;
				this.RaisePropertyChanged("Count_Sheet_Created_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Count_Sheet_Created_On_or_BeforeSpecified
		{
			get
			{
				return this.count_Sheet_Created_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.count_Sheet_Created_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Count_Sheet_Created_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Count_Sheet_Statuses_Reference", Order = 4)]
		public Document_StatusObjectType[] Count_Sheet_Statuses_Reference
		{
			get
			{
				return this.count_Sheet_Statuses_ReferenceField;
			}
			set
			{
				this.count_Sheet_Statuses_ReferenceField = value;
				this.RaisePropertyChanged("Count_Sheet_Statuses_Reference");
			}
		}

		[XmlElement("Assigned_To_Workers_Reference", Order = 5)]
		public WorkerObjectType[] Assigned_To_Workers_Reference
		{
			get
			{
				return this.assigned_To_Workers_ReferenceField;
			}
			set
			{
				this.assigned_To_Workers_ReferenceField = value;
				this.RaisePropertyChanged("Assigned_To_Workers_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Exclude_Cancelled
		{
			get
			{
				return this.exclude_CancelledField;
			}
			set
			{
				this.exclude_CancelledField = value;
				this.RaisePropertyChanged("Exclude_Cancelled");
			}
		}

		[XmlIgnore]
		public bool Exclude_CancelledSpecified
		{
			get
			{
				return this.exclude_CancelledFieldSpecified;
			}
			set
			{
				this.exclude_CancelledFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_CancelledSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Exclude_Closed
		{
			get
			{
				return this.exclude_ClosedField;
			}
			set
			{
				this.exclude_ClosedField = value;
				this.RaisePropertyChanged("Exclude_Closed");
			}
		}

		[XmlIgnore]
		public bool Exclude_ClosedSpecified
		{
			get
			{
				return this.exclude_ClosedFieldSpecified;
			}
			set
			{
				this.exclude_ClosedFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_ClosedSpecified");
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
