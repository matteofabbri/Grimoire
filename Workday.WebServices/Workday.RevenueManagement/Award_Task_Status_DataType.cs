using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_Status_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private string idField;

		private string status_NameField;

		private bool defaultField;

		private bool defaultFieldSpecified;

		private bool indicates_Task_Is_DoneField;

		private bool indicates_Task_Is_DoneFieldSpecified;

		private bool award_Task_Status_for_BP_CompleteField;

		private bool award_Task_Status_for_BP_CompleteFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Status_Name
		{
			get
			{
				return this.status_NameField;
			}
			set
			{
				this.status_NameField = value;
				this.RaisePropertyChanged("Status_Name");
			}
		}

		[XmlElement(Order = 3)]
		public bool Default
		{
			get
			{
				return this.defaultField;
			}
			set
			{
				this.defaultField = value;
				this.RaisePropertyChanged("Default");
			}
		}

		[XmlIgnore]
		public bool DefaultSpecified
		{
			get
			{
				return this.defaultFieldSpecified;
			}
			set
			{
				this.defaultFieldSpecified = value;
				this.RaisePropertyChanged("DefaultSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Indicates_Task_Is_Done
		{
			get
			{
				return this.indicates_Task_Is_DoneField;
			}
			set
			{
				this.indicates_Task_Is_DoneField = value;
				this.RaisePropertyChanged("Indicates_Task_Is_Done");
			}
		}

		[XmlIgnore]
		public bool Indicates_Task_Is_DoneSpecified
		{
			get
			{
				return this.indicates_Task_Is_DoneFieldSpecified;
			}
			set
			{
				this.indicates_Task_Is_DoneFieldSpecified = value;
				this.RaisePropertyChanged("Indicates_Task_Is_DoneSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Award_Task_Status_for_BP_Complete
		{
			get
			{
				return this.award_Task_Status_for_BP_CompleteField;
			}
			set
			{
				this.award_Task_Status_for_BP_CompleteField = value;
				this.RaisePropertyChanged("Award_Task_Status_for_BP_Complete");
			}
		}

		[XmlIgnore]
		public bool Award_Task_Status_for_BP_CompleteSpecified
		{
			get
			{
				return this.award_Task_Status_for_BP_CompleteFieldSpecified;
			}
			set
			{
				this.award_Task_Status_for_BP_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Award_Task_Status_for_BP_CompleteSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
