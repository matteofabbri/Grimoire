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
	public class Pay_Group_Assignment_Correct_or_Rescinded_Organization_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private DateTime completed_OnField;

		private bool completed_OnFieldSpecified;

		private bool event_CorrectedField;

		private bool event_CorrectedFieldSpecified;

		private bool event_RescindedField;

		private bool event_RescindedFieldSpecified;

		private Pay_GroupObjectType original_Pay_Group_ReferenceField;

		private Pay_GroupObjectType proposed_Pay_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Completed_On
		{
			get
			{
				return this.completed_OnField;
			}
			set
			{
				this.completed_OnField = value;
				this.RaisePropertyChanged("Completed_On");
			}
		}

		[XmlIgnore]
		public bool Completed_OnSpecified
		{
			get
			{
				return this.completed_OnFieldSpecified;
			}
			set
			{
				this.completed_OnFieldSpecified = value;
				this.RaisePropertyChanged("Completed_OnSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Event_Corrected
		{
			get
			{
				return this.event_CorrectedField;
			}
			set
			{
				this.event_CorrectedField = value;
				this.RaisePropertyChanged("Event_Corrected");
			}
		}

		[XmlIgnore]
		public bool Event_CorrectedSpecified
		{
			get
			{
				return this.event_CorrectedFieldSpecified;
			}
			set
			{
				this.event_CorrectedFieldSpecified = value;
				this.RaisePropertyChanged("Event_CorrectedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Event_Rescinded
		{
			get
			{
				return this.event_RescindedField;
			}
			set
			{
				this.event_RescindedField = value;
				this.RaisePropertyChanged("Event_Rescinded");
			}
		}

		[XmlIgnore]
		public bool Event_RescindedSpecified
		{
			get
			{
				return this.event_RescindedFieldSpecified;
			}
			set
			{
				this.event_RescindedFieldSpecified = value;
				this.RaisePropertyChanged("Event_RescindedSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Pay_GroupObjectType Original_Pay_Group_Reference
		{
			get
			{
				return this.original_Pay_Group_ReferenceField;
			}
			set
			{
				this.original_Pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Original_Pay_Group_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Pay_GroupObjectType Proposed_Pay_Group_Reference
		{
			get
			{
				return this.proposed_Pay_Group_ReferenceField;
			}
			set
			{
				this.proposed_Pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Proposed_Pay_Group_Reference");
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
