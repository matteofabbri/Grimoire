using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Unreserve_Inventory_ResponseType : INotifyPropertyChanged
	{
		private Submit_Unreserve_Inventory_Response_LineType[] submit_Unreserve_Inventory_Response_LineField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Submit_Unreserve_Inventory_Response_Line", Order = 0)]
		public Submit_Unreserve_Inventory_Response_LineType[] Submit_Unreserve_Inventory_Response_Line
		{
			get
			{
				return this.submit_Unreserve_Inventory_Response_LineField;
			}
			set
			{
				this.submit_Unreserve_Inventory_Response_LineField = value;
				this.RaisePropertyChanged("Submit_Unreserve_Inventory_Response_Line");
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
