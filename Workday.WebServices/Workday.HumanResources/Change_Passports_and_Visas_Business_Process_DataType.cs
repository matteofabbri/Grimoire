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
	public class Change_Passports_and_Visas_Business_Process_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Passports_and_Visas_Identification_DataType passports_and_Visas_Identification_DataField;

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
		public Passports_and_Visas_Identification_DataType Passports_and_Visas_Identification_Data
		{
			get
			{
				return this.passports_and_Visas_Identification_DataField;
			}
			set
			{
				this.passports_and_Visas_Identification_DataField = value;
				this.RaisePropertyChanged("Passports_and_Visas_Identification_Data");
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
