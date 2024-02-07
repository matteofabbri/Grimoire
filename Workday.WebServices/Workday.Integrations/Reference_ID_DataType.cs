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
	public class Reference_ID_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string new_IDField;

		private string reference_ID_TypeField;

		private string referenced_Object_DescriptorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string New_ID
		{
			get
			{
				return this.new_IDField;
			}
			set
			{
				this.new_IDField = value;
				this.RaisePropertyChanged("New_ID");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Referenced_Object_Descriptor
		{
			get
			{
				return this.referenced_Object_DescriptorField;
			}
			set
			{
				this.referenced_Object_DescriptorField = value;
				this.RaisePropertyChanged("Referenced_Object_Descriptor");
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
