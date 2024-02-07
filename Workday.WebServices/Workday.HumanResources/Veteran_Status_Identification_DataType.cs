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
	public class Veteran_Status_Identification_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private US_Veteran_StatusObjectType uS_Veteran_ReferenceField;

		private US_Protected_Veteran_Status_TypeObjectType[] uS_Protected_Veteran_Status_Type_ReferenceField;

		private DateTime discharge_DateField;

		private bool discharge_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public US_Veteran_StatusObjectType US_Veteran_Reference
		{
			get
			{
				return this.uS_Veteran_ReferenceField;
			}
			set
			{
				this.uS_Veteran_ReferenceField = value;
				this.RaisePropertyChanged("US_Veteran_Reference");
			}
		}

		[XmlElement("US_Protected_Veteran_Status_Type_Reference", Order = 2)]
		public US_Protected_Veteran_Status_TypeObjectType[] US_Protected_Veteran_Status_Type_Reference
		{
			get
			{
				return this.uS_Protected_Veteran_Status_Type_ReferenceField;
			}
			set
			{
				this.uS_Protected_Veteran_Status_Type_ReferenceField = value;
				this.RaisePropertyChanged("US_Protected_Veteran_Status_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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
