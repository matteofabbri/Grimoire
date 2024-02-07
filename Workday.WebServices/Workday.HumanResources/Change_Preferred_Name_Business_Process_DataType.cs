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
	public class Change_Preferred_Name_Business_Process_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private bool use_Legal_Name_As_Preferred_NameField;

		private bool use_Legal_Name_As_Preferred_NameFieldSpecified;

		private Person_Name_Detail_DataType name_DataField;

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
		public bool Use_Legal_Name_As_Preferred_Name
		{
			get
			{
				return this.use_Legal_Name_As_Preferred_NameField;
			}
			set
			{
				this.use_Legal_Name_As_Preferred_NameField = value;
				this.RaisePropertyChanged("Use_Legal_Name_As_Preferred_Name");
			}
		}

		[XmlIgnore]
		public bool Use_Legal_Name_As_Preferred_NameSpecified
		{
			get
			{
				return this.use_Legal_Name_As_Preferred_NameFieldSpecified;
			}
			set
			{
				this.use_Legal_Name_As_Preferred_NameFieldSpecified = value;
				this.RaisePropertyChanged("Use_Legal_Name_As_Preferred_NameSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Person_Name_Detail_DataType Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
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
