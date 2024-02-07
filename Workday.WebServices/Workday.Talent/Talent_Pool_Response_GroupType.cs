using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Talent_Pool_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Talent_Pool_DataField;

		private bool include_Talent_Pool_DataFieldSpecified;

		private bool include_Shareable_DataField;

		private bool include_Shareable_DataFieldSpecified;

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
		public bool Include_Talent_Pool_Data
		{
			get
			{
				return this.include_Talent_Pool_DataField;
			}
			set
			{
				this.include_Talent_Pool_DataField = value;
				this.RaisePropertyChanged("Include_Talent_Pool_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Talent_Pool_DataSpecified
		{
			get
			{
				return this.include_Talent_Pool_DataFieldSpecified;
			}
			set
			{
				this.include_Talent_Pool_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Talent_Pool_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Shareable_Data
		{
			get
			{
				return this.include_Shareable_DataField;
			}
			set
			{
				this.include_Shareable_DataField = value;
				this.RaisePropertyChanged("Include_Shareable_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Shareable_DataSpecified
		{
			get
			{
				return this.include_Shareable_DataFieldSpecified;
			}
			set
			{
				this.include_Shareable_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Shareable_DataSpecified");
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
