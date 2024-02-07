using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Contract_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Award_Contract_dataField;

		private bool include_Award_Contract_dataFieldSpecified;

		private bool include_Attachment_dataField;

		private bool include_Attachment_dataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Award_Contract_data
		{
			get
			{
				return this.include_Award_Contract_dataField;
			}
			set
			{
				this.include_Award_Contract_dataField = value;
				this.RaisePropertyChanged("Include_Award_Contract_data");
			}
		}

		[XmlIgnore]
		public bool Include_Award_Contract_dataSpecified
		{
			get
			{
				return this.include_Award_Contract_dataFieldSpecified;
			}
			set
			{
				this.include_Award_Contract_dataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Award_Contract_dataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Attachment_data
		{
			get
			{
				return this.include_Attachment_dataField;
			}
			set
			{
				this.include_Attachment_dataField = value;
				this.RaisePropertyChanged("Include_Attachment_data");
			}
		}

		[XmlIgnore]
		public bool Include_Attachment_dataSpecified
		{
			get
			{
				return this.include_Attachment_dataFieldSpecified;
			}
			set
			{
				this.include_Attachment_dataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Attachment_dataSpecified");
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
