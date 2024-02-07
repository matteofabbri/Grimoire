using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Custom_List_DataType : INotifyPropertyChanged
	{
		private string web_Service_AliasField;

		private string custom_Field_Type_NameField;

		private bool do_Not_UseField;

		private bool do_Not_UseFieldSpecified;

		private Custom_List_ValueType[] custom_List_Value_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Web_Service_Alias
		{
			get
			{
				return this.web_Service_AliasField;
			}
			set
			{
				this.web_Service_AliasField = value;
				this.RaisePropertyChanged("Web_Service_Alias");
			}
		}

		[XmlElement(Order = 1)]
		public string Custom_Field_Type_Name
		{
			get
			{
				return this.custom_Field_Type_NameField;
			}
			set
			{
				this.custom_Field_Type_NameField = value;
				this.RaisePropertyChanged("Custom_Field_Type_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Do_Not_Use
		{
			get
			{
				return this.do_Not_UseField;
			}
			set
			{
				this.do_Not_UseField = value;
				this.RaisePropertyChanged("Do_Not_Use");
			}
		}

		[XmlIgnore]
		public bool Do_Not_UseSpecified
		{
			get
			{
				return this.do_Not_UseFieldSpecified;
			}
			set
			{
				this.do_Not_UseFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_UseSpecified");
			}
		}

		[XmlElement("Custom_List_Value_Data", Order = 3)]
		public Custom_List_ValueType[] Custom_List_Value_Data
		{
			get
			{
				return this.custom_List_Value_DataField;
			}
			set
			{
				this.custom_List_Value_DataField = value;
				this.RaisePropertyChanged("Custom_List_Value_Data");
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
