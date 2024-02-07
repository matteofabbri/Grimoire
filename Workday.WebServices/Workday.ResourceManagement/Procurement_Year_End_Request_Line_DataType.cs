using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Procurement_Year_End_Request_Line_DataType : INotifyPropertyChanged
	{
		private Business_DocumentObjectType business_Document_ReferenceField;

		private string memoField;

		private bool exclude_from_ProcessField;

		private bool exclude_from_ProcessFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_DocumentObjectType Business_Document_Reference
		{
			get
			{
				return this.business_Document_ReferenceField;
			}
			set
			{
				this.business_Document_ReferenceField = value;
				this.RaisePropertyChanged("Business_Document_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 2)]
		public bool Exclude_from_Process
		{
			get
			{
				return this.exclude_from_ProcessField;
			}
			set
			{
				this.exclude_from_ProcessField = value;
				this.RaisePropertyChanged("Exclude_from_Process");
			}
		}

		[XmlIgnore]
		public bool Exclude_from_ProcessSpecified
		{
			get
			{
				return this.exclude_from_ProcessFieldSpecified;
			}
			set
			{
				this.exclude_from_ProcessFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_from_ProcessSpecified");
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
