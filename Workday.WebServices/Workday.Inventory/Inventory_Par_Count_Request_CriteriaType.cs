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
	public class Inventory_Par_Count_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private LocationObjectType par_Location_ReferenceField;

		private string par_Count_NumberField;

		private DateTime par_Count_Created_On_or_AfterField;

		private bool par_Count_Created_On_or_AfterFieldSpecified;

		private DateTime par_Count_Created_On_or_BeforeField;

		private bool par_Count_Created_On_or_BeforeFieldSpecified;

		private Document_StatusObjectType[] par_Count_Statuses_ReferenceField;

		private WorkerObjectType[] created_By_Worker_ReferenceField;

		private bool exclude_CanceledField;

		private bool exclude_CanceledFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Par_Location_Reference
		{
			get
			{
				return this.par_Location_ReferenceField;
			}
			set
			{
				this.par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Par_Location_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Par_Count_Number
		{
			get
			{
				return this.par_Count_NumberField;
			}
			set
			{
				this.par_Count_NumberField = value;
				this.RaisePropertyChanged("Par_Count_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Par_Count_Created_On_or_After
		{
			get
			{
				return this.par_Count_Created_On_or_AfterField;
			}
			set
			{
				this.par_Count_Created_On_or_AfterField = value;
				this.RaisePropertyChanged("Par_Count_Created_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Par_Count_Created_On_or_AfterSpecified
		{
			get
			{
				return this.par_Count_Created_On_or_AfterFieldSpecified;
			}
			set
			{
				this.par_Count_Created_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Par_Count_Created_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Par_Count_Created_On_or_Before
		{
			get
			{
				return this.par_Count_Created_On_or_BeforeField;
			}
			set
			{
				this.par_Count_Created_On_or_BeforeField = value;
				this.RaisePropertyChanged("Par_Count_Created_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Par_Count_Created_On_or_BeforeSpecified
		{
			get
			{
				return this.par_Count_Created_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.par_Count_Created_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Par_Count_Created_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Par_Count_Statuses_Reference", Order = 5)]
		public Document_StatusObjectType[] Par_Count_Statuses_Reference
		{
			get
			{
				return this.par_Count_Statuses_ReferenceField;
			}
			set
			{
				this.par_Count_Statuses_ReferenceField = value;
				this.RaisePropertyChanged("Par_Count_Statuses_Reference");
			}
		}

		[XmlElement("Created_By_Worker_Reference", Order = 6)]
		public WorkerObjectType[] Created_By_Worker_Reference
		{
			get
			{
				return this.created_By_Worker_ReferenceField;
			}
			set
			{
				this.created_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Exclude_Canceled
		{
			get
			{
				return this.exclude_CanceledField;
			}
			set
			{
				this.exclude_CanceledField = value;
				this.RaisePropertyChanged("Exclude_Canceled");
			}
		}

		[XmlIgnore]
		public bool Exclude_CanceledSpecified
		{
			get
			{
				return this.exclude_CanceledFieldSpecified;
			}
			set
			{
				this.exclude_CanceledFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_CanceledSpecified");
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
