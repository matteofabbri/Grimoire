using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Feedback_ReceivedType : INotifyPropertyChanged
	{
		private string fromField;

		private WorkerObjectType requested_By_Worker_ReferenceField;

		private string feedback_TypeField;

		private DateTime dateField;

		private bool dateFieldSpecified;

		private Feedback_ResponseType[] feedback_Response_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string From
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
				this.RaisePropertyChanged("From");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Requested_By_Worker_Reference
		{
			get
			{
				return this.requested_By_Worker_ReferenceField;
			}
			set
			{
				this.requested_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Requested_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Feedback_Type
		{
			get
			{
				return this.feedback_TypeField;
			}
			set
			{
				this.feedback_TypeField = value;
				this.RaisePropertyChanged("Feedback_Type");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlIgnore]
		public bool DateSpecified
		{
			get
			{
				return this.dateFieldSpecified;
			}
			set
			{
				this.dateFieldSpecified = value;
				this.RaisePropertyChanged("DateSpecified");
			}
		}

		[XmlElement("Feedback_Response_Data", Order = 4)]
		public Feedback_ResponseType[] Feedback_Response_Data
		{
			get
			{
				return this.feedback_Response_DataField;
			}
			set
			{
				this.feedback_Response_DataField = value;
				this.RaisePropertyChanged("Feedback_Response_Data");
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
