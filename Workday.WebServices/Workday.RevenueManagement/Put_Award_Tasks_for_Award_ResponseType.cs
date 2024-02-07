using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Award_Tasks_for_Award_ResponseType : INotifyPropertyChanged
	{
		private Award_ContractObjectType award_ReferenceField;

		private Award_TaskObjectType[] award_Task_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_ContractObjectType Award_Reference
		{
			get
			{
				return this.award_ReferenceField;
			}
			set
			{
				this.award_ReferenceField = value;
				this.RaisePropertyChanged("Award_Reference");
			}
		}

		[XmlElement("Award_Task_Reference", Order = 1)]
		public Award_TaskObjectType[] Award_Task_Reference
		{
			get
			{
				return this.award_Task_ReferenceField;
			}
			set
			{
				this.award_Task_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
