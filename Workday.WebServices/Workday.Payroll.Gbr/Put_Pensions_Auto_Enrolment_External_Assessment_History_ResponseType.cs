using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Pensions_Auto_Enrolment_External_Assessment_History_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType pensions_Auto_Enrolment_External_Assessment_History_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Pensions_Auto_Enrolment_External_Assessment_History_Reference
		{
			get
			{
				return this.pensions_Auto_Enrolment_External_Assessment_History_ReferenceField;
			}
			set
			{
				this.pensions_Auto_Enrolment_External_Assessment_History_ReferenceField = value;
				this.RaisePropertyChanged("Pensions_Auto_Enrolment_External_Assessment_History_Reference");
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
