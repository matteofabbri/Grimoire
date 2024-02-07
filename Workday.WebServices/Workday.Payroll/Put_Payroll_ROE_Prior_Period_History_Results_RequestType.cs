using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_ROE_Prior_Period_History_Results_RequestType : INotifyPropertyChanged
	{
		private Payroll_ROE_Prior_History_Results_DataType payroll_ROE_Prior_Period_History_Results_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_ROE_Prior_History_Results_DataType Payroll_ROE_Prior_Period_History_Results_Data
		{
			get
			{
				return this.payroll_ROE_Prior_Period_History_Results_DataField;
			}
			set
			{
				this.payroll_ROE_Prior_Period_History_Results_DataField = value;
				this.RaisePropertyChanged("Payroll_ROE_Prior_Period_History_Results_Data");
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
