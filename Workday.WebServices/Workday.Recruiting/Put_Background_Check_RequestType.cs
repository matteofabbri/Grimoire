using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Background_Check_RequestType : INotifyPropertyChanged
	{
		private Business_Process_ParametersType business_Process_ParametersField;

		private Dynamic_Business_Process_ParametersType dynamic_Business_Process_ParametersField;

		private Background_Check_DataType background_Check_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 1)]
		public Dynamic_Business_Process_ParametersType Dynamic_Business_Process_Parameters
		{
			get
			{
				return this.dynamic_Business_Process_ParametersField;
			}
			set
			{
				this.dynamic_Business_Process_ParametersField = value;
				this.RaisePropertyChanged("Dynamic_Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 2)]
		public Background_Check_DataType Background_Check_Data
		{
			get
			{
				return this.background_Check_DataField;
			}
			set
			{
				this.background_Check_DataField = value;
				this.RaisePropertyChanged("Background_Check_Data");
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
