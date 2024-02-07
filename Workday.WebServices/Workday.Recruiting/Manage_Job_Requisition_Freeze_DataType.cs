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
	public class Manage_Job_Requisition_Freeze_DataType : INotifyPropertyChanged
	{
		private Job_Requisition_EnabledObjectType job_Requisition_ReferenceField;

		private Event_Classification_SubcategoryObjectType freeze_Unfreeze_Reason_ReferenceField;

		private DateTime freeze_Unfreeze_DateField;

		private bool frozenField;

		private bool frozenFieldSpecified;

		private Unpost_Job_Sub_Business_ProcessType unpost_Job_Sub_Business_ProcessField;

		private Post_Job_Sub_Business_ProcessType post_Job_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_Requisition_EnabledObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Freeze_Unfreeze_Reason_Reference
		{
			get
			{
				return this.freeze_Unfreeze_Reason_ReferenceField;
			}
			set
			{
				this.freeze_Unfreeze_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Freeze_Unfreeze_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Freeze_Unfreeze_Date
		{
			get
			{
				return this.freeze_Unfreeze_DateField;
			}
			set
			{
				this.freeze_Unfreeze_DateField = value;
				this.RaisePropertyChanged("Freeze_Unfreeze_Date");
			}
		}

		[XmlElement(Order = 3)]
		public bool Frozen
		{
			get
			{
				return this.frozenField;
			}
			set
			{
				this.frozenField = value;
				this.RaisePropertyChanged("Frozen");
			}
		}

		[XmlIgnore]
		public bool FrozenSpecified
		{
			get
			{
				return this.frozenFieldSpecified;
			}
			set
			{
				this.frozenFieldSpecified = value;
				this.RaisePropertyChanged("FrozenSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Unpost_Job_Sub_Business_ProcessType Unpost_Job_Sub_Business_Process
		{
			get
			{
				return this.unpost_Job_Sub_Business_ProcessField;
			}
			set
			{
				this.unpost_Job_Sub_Business_ProcessField = value;
				this.RaisePropertyChanged("Unpost_Job_Sub_Business_Process");
			}
		}

		[XmlElement(Order = 5)]
		public Post_Job_Sub_Business_ProcessType Post_Job_Sub_Process
		{
			get
			{
				return this.post_Job_Sub_ProcessField;
			}
			set
			{
				this.post_Job_Sub_ProcessField = value;
				this.RaisePropertyChanged("Post_Job_Sub_Process");
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
