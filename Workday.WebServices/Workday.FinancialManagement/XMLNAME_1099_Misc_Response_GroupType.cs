using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class XMLNAME_1099_Misc_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_1099_Misc_ReferenceField;

		private bool include_1099_Misc_ReferenceFieldSpecified;

		private bool include_1099_Misc_DataField;

		private bool include_1099_Misc_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_1099_Misc_Reference
		{
			get
			{
				return this.include_1099_Misc_ReferenceField;
			}
			set
			{
				this.include_1099_Misc_ReferenceField = value;
				this.RaisePropertyChanged("Include_1099_Misc_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_1099_Misc_ReferenceSpecified
		{
			get
			{
				return this.include_1099_Misc_ReferenceFieldSpecified;
			}
			set
			{
				this.include_1099_Misc_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_1099_Misc_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_1099_Misc_Data
		{
			get
			{
				return this.include_1099_Misc_DataField;
			}
			set
			{
				this.include_1099_Misc_DataField = value;
				this.RaisePropertyChanged("Include_1099_Misc_Data");
			}
		}

		[XmlIgnore]
		public bool Include_1099_Misc_DataSpecified
		{
			get
			{
				return this.include_1099_Misc_DataFieldSpecified;
			}
			set
			{
				this.include_1099_Misc_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_1099_Misc_DataSpecified");
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
