using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Launch_Integration_Event_RequestType : INotifyPropertyChanged
	{
		private Integration_System__Audited_ObjectType integration_System_ReferenceField;

		private bool invoke_Integration_As_Current_UserField;

		private bool invoke_Integration_As_Current_UserFieldSpecified;

		private Integration_Launch_Parameter_DataType[] integration_Launch_Parameter_DataField;

		private Integration_Repository_Document_DataType[] listener_Document_DataField;

		private bool debug_ModeField;

		private bool debug_ModeFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_System__Audited_ObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Invoke_Integration_As_Current_User
		{
			get
			{
				return this.invoke_Integration_As_Current_UserField;
			}
			set
			{
				this.invoke_Integration_As_Current_UserField = value;
				this.RaisePropertyChanged("Invoke_Integration_As_Current_User");
			}
		}

		[XmlIgnore]
		public bool Invoke_Integration_As_Current_UserSpecified
		{
			get
			{
				return this.invoke_Integration_As_Current_UserFieldSpecified;
			}
			set
			{
				this.invoke_Integration_As_Current_UserFieldSpecified = value;
				this.RaisePropertyChanged("Invoke_Integration_As_Current_UserSpecified");
			}
		}

		[XmlElement("Integration_Launch_Parameter_Data", Order = 2)]
		public Integration_Launch_Parameter_DataType[] Integration_Launch_Parameter_Data
		{
			get
			{
				return this.integration_Launch_Parameter_DataField;
			}
			set
			{
				this.integration_Launch_Parameter_DataField = value;
				this.RaisePropertyChanged("Integration_Launch_Parameter_Data");
			}
		}

		[XmlElement("Listener_Document_Data", Order = 3)]
		public Integration_Repository_Document_DataType[] Listener_Document_Data
		{
			get
			{
				return this.listener_Document_DataField;
			}
			set
			{
				this.listener_Document_DataField = value;
				this.RaisePropertyChanged("Listener_Document_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Debug_Mode
		{
			get
			{
				return this.debug_ModeField;
			}
			set
			{
				this.debug_ModeField = value;
				this.RaisePropertyChanged("Debug_Mode");
			}
		}

		[XmlIgnore]
		public bool Debug_ModeSpecified
		{
			get
			{
				return this.debug_ModeFieldSpecified;
			}
			set
			{
				this.debug_ModeFieldSpecified = value;
				this.RaisePropertyChanged("Debug_ModeSpecified");
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
