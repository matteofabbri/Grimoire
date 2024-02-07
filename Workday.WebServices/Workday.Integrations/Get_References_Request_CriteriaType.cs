using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_References_Request_CriteriaType : INotifyPropertyChanged
	{
		private string reference_ID_TypeField;

		private bool include_Defaulted_Values_OnlyField;

		private bool include_Defaulted_Values_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Reference_ID_Type
		{
			get
			{
				return this.reference_ID_TypeField;
			}
			set
			{
				this.reference_ID_TypeField = value;
				this.RaisePropertyChanged("Reference_ID_Type");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Defaulted_Values_Only
		{
			get
			{
				return this.include_Defaulted_Values_OnlyField;
			}
			set
			{
				this.include_Defaulted_Values_OnlyField = value;
				this.RaisePropertyChanged("Include_Defaulted_Values_Only");
			}
		}

		[XmlIgnore]
		public bool Include_Defaulted_Values_OnlySpecified
		{
			get
			{
				return this.include_Defaulted_Values_OnlyFieldSpecified;
			}
			set
			{
				this.include_Defaulted_Values_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Include_Defaulted_Values_OnlySpecified");
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
