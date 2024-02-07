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
	public class Subaward_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Subaward_DataField;

		private bool include_Subaward_DataFieldSpecified;

		private bool include_Attachment_DataField;

		private bool include_Attachment_DataFieldSpecified;

		private bool include_Contact_DataField;

		private bool include_Contact_DataFieldSpecified;

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
		public bool Include_Subaward_Data
		{
			get
			{
				return this.include_Subaward_DataField;
			}
			set
			{
				this.include_Subaward_DataField = value;
				this.RaisePropertyChanged("Include_Subaward_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Subaward_DataSpecified
		{
			get
			{
				return this.include_Subaward_DataFieldSpecified;
			}
			set
			{
				this.include_Subaward_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Subaward_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Attachment_Data
		{
			get
			{
				return this.include_Attachment_DataField;
			}
			set
			{
				this.include_Attachment_DataField = value;
				this.RaisePropertyChanged("Include_Attachment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Attachment_DataSpecified
		{
			get
			{
				return this.include_Attachment_DataFieldSpecified;
			}
			set
			{
				this.include_Attachment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Attachment_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Contact_Data
		{
			get
			{
				return this.include_Contact_DataField;
			}
			set
			{
				this.include_Contact_DataField = value;
				this.RaisePropertyChanged("Include_Contact_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Contact_DataSpecified
		{
			get
			{
				return this.include_Contact_DataFieldSpecified;
			}
			set
			{
				this.include_Contact_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Contact_DataSpecified");
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
